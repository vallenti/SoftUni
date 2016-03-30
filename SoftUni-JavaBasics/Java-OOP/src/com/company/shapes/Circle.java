package com.company.shapes;


public class Circle extends  PlaneShape{
    private Vertex2D center;
    private int radius;

    public Circle(Vertex2D center, int radius) {
        setCenter(center);
        setRadius(radius);
    }

    public Vertex2D getCenter() {
        return center;
    }

    public void setCenter(Vertex2D center) {
        this.center = center;
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        //TODO check if not < 0
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return Math.PI*radius*radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * radius;
    }

    @Override
    public String toString(){
        return "Circle => "+"Center("
                +this.getCenter().getX()
                +","+this.getCenter().getY()
                +") Radius: "+this.getRadius()
                +" Perimeter: "+this.getPerimeter()
                +" Area: "+this.getArea();
    }

    @Override
    public int compareTo(Object obj) {
        PlaneShape plane = (PlaneShape)obj;
        if(this.getPerimeter()>plane.getPerimeter()) {
            return 1;
        } else if(this.getPerimeter()<plane.getPerimeter()) {
            return -1;
        }else {
            return 0;
        }
    }
}
