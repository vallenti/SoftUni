package com.company.shapes;


public class Triangle extends PlaneShape {
    private Vertex2D a;
    private Vertex2D b;
    private Vertex2D c;
    private double sideA;
    private double sideB;
    private double sideC;


    public Triangle(Vertex2D a, Vertex2D b, Vertex2D c) {
        setA(a);
        setB(b);
        setC(c);
        this.sideA = Vertex2D.vertexDistance(this.getB(), this.getC());
        this.sideB = Vertex2D.vertexDistance(this.getC(), this.getA());
        this.sideC = Vertex2D.vertexDistance(this.getA(), this.getB());
    }

    public Vertex2D getA() {
        return a;
    }

    public void setA(Vertex2D a) {
        this.a = a;
    }

    public Vertex2D getB() {
        return b;
    }

    public void setB(Vertex2D b) {
        this.b = b;
    }

    public Vertex2D getC() {
        return c;
    }

    public void setC(Vertex2D c) {
        this.c = c;
    }

    @Override
    public double getArea() {
        double halfPerimeter = this.getPerimeter() / 2;
        return Math.sqrt(halfPerimeter*(halfPerimeter-this.sideA)*(halfPerimeter-this.sideB)*(halfPerimeter-this.sideC));
    }

    @Override
    public double getPerimeter() {
        return this.sideA + this.sideB + this.sideC;
    }

    @Override
    public String toString(){
        return "Triangle => A("
                +this.getA().getX()+","+this.getA().getY()+")"
                +" B("+this.getB().getX()+","+this.getB().getY()+")"
                +" C("+this.getC().getX()+","+this.getC().getY()+")"
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
