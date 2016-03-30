package com.company.shapes;


public class Rectangle extends PlaneShape {
    private Vertex2D upperLeftVertex;
    private int height;
    private int width;

    public Rectangle(Vertex2D upperLeftVertex, int height, int width) {
        setUpperLeftVertex(upperLeftVertex);
        setHeight(height);
        setWidth(width);
    }

    public Vertex2D getUpperLeftVertex() {
        return upperLeftVertex;
    }

    public void setUpperLeftVertex(Vertex2D upperLeftVertex) {
        this.upperLeftVertex = upperLeftVertex;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        //TODO check if height is not < 0 or throw exception
        this.height = height;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        //TODO check if width is not < 0 or throw exception
        this.width = width;
    }

    @Override
    public double getArea() {
        return this.getWidth() * this.getHeight();
    }

    @Override
    public double getPerimeter() {
        return 2 * this.getWidth() + 2 * this.getHeight();
    }

    @Override
    public String toString(){
        return "Rectangle => Height: "
                +this.getHeight()
                +" Width: "+this.getWidth()
                +" Vertex: ("+this.getUpperLeftVertex().getX()+","+this.getUpperLeftVertex().getY()+")"
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
