/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package pingponggame;


import java.net.URL;
import java.util.ResourceBundle;
import javafx.animation.KeyFrame;
import javafx.animation.PathTransition;
import javafx.animation.Timeline;
import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.event.Event;
import javafx.event.EventHandler;
import javafx.event.EventType;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.LineTo;
import javafx.scene.shape.MoveTo;
import javafx.scene.shape.Path;
import javafx.scene.shape.Rectangle;
import javafx.util.Duration;

public class PingPongController implements Initializable {
    
    @FXML
    private Rectangle firstPlayerPad;
    
    @FXML
    private Rectangle secondPlayerPad;
    
    @FXML
    private Circle ball;
    
    @FXML
    Pane pane;
    
    @FXML
    Button startButton; 
            
    
    
    @FXML
    public void moveFirstPlayer(KeyEvent e){
        PathTransition pt = new PathTransition();
        Path path = new Path();
        if( firstPlayerPad.getLayoutY()<=pane.getPrefHeight()-100)
        {
            if(e.getCode()==KeyCode.DOWN)
            {
               //path.getElements().add(new MoveTo(firstPlayerPad.getLayoutX(),firstPlayerPad.getLayoutY()));
               path.getElements().add(new LineTo(firstPlayerPad.getLayoutX(), firstPlayerPad.getLayoutY()+5));   
               pt.setNode(firstPlayerPad);
               pt.setDuration(Duration.INDEFINITE);
               pt.setPath(path);
               pt.setCycleCount(1);
               pt.play();
               firstPlayerPad.setLayoutY(firstPlayerPad.getLayoutY()+5);
            }
        }
            if(firstPlayerPad.getLayoutY()>=0)
            {
            if(e.getCode()==KeyCode.UP)
            {
               //path.getElements().add(new MoveTo(firstPlayerPad.getLayoutX(),firstPlayerPad.getLayoutY()));
               path.getElements().add(new LineTo(firstPlayerPad.getLayoutX(), firstPlayerPad.getLayoutY()-5));   
               pt.setNode(firstPlayerPad);
               pt.setDuration(Duration.INDEFINITE);
               pt.setPath(path);
               pt.setCycleCount(1);
               pt.play();
               firstPlayerPad.setLayoutY(firstPlayerPad.getLayoutY()-5);
            }

        }
    }
    
    @FXML
    public void startGame(){
      // Ball ball = new Ball();
      //  ball.start();
        pane.requestFocus();
        
       
    }
    
  
    class Ball extends Thread {
        
        double ballX = ball.getLayoutX(),ballY=ball.getLayoutY();
        int ballDirection=1;
        int ballRadius = 20;
        
        @Override
        public void run(){
            
            while(true){
                switch(ballDirection){
                    case 1: ballX++;ballY--;break;                    
                    case 2: ballX--;ballY--;break;
                    case 3: ballX--;ballY++;break;
                    case 4: ballX++;ballY++;break;

                }
                PathTransition se1 = new PathTransition();
                Path SE = new Path();
                Path NE = new Path();
                Path NW = new Path();
                Path SW = new Path();
                if(ball.getLayoutX()<=pane.getPrefWidth() && ball.getLayoutY()<=pane.getPrefHeight()){
                    SE.getElements().add(new MoveTo(ball.getLayoutX(), ball.getLayoutY()));
                    SE.getElements().add(new LineTo(ball.getLayoutX()+5, ball.getLayoutY()+5));

                   se1.setNode(ball);
                   se1.setDuration(Duration.seconds(1));
                   se1.setPath(SE);
                   se1.setCycleCount(1);
                   se1.play();
                }
                
                if(ballX>pane.getWidth()-ballRadius)ballDirection= (ballDirection==4?3:2);
                if(ballX<0) ballDirection=(ballDirection==3?4:1);
                if(ballY>pane.getHeight()-ballRadius) ballDirection = (ballDirection==4?1:2);
                if(ballY<0) ballDirection=(ballDirection==1?4:3);
                Ball.yield();
                
            }
        }
    }

    
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
        
    };

}