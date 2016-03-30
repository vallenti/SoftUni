package com.company.shapes;


public class Vertex2D extends Vertex {
    private int x;
    private int y;

    public Vertex2D(int x, int y) {
        setX(x);
        setY(y);
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public static double vertexDistance(Vertex2D v1, Vertex2D v2) {
        return Math.sqrt(Math.pow((v1.getX()-v2.getX()),2) +Math.pow((v1.getY()-v2.getY()),2));
    }
}
