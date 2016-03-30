package com.company.shapes;


public class Sphere extends  SpaceShape {
    private Vertex3D center;
    private int radius;

    public Sphere(Vertex3D center, int radius) {
        setCenter(center);
        setRadius(radius);
    }

    public Vertex3D getCenter() {
        return center;
    }

    public void setCenter(Vertex3D center) {
        this.center = center;
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        //TODO < 0
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * Math.pow(this.getRadius(),2);
    }

    @Override
    public double getVolume() {
        return (4/3) * Math.PI * Math.pow(this.getRadius(),3);

    }

    @Override
    public String toString(){
        return "Sphere => Center: ("
                +this.getCenter().getX()+","+this.getCenter().getY()+","+this.getCenter().getZ()+")"
                +" Radius: "+this.getRadius()
                +" Area: "+this.getArea()
                +" Volume: "+this.getVolume();
    }
}
