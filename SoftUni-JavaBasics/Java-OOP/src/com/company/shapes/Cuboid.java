package com.company.shapes;


public class Cuboid extends  SpaceShape {
    private Vertex3D vertex;
    private int width;
    private int height;
    private int depth;

    public Cuboid(Vertex3D vertex, int width, int height, int depth) {
        setVertex(vertex);
        setWidth(width);
        setHeight(height);
        setDepth(depth);
    }

    public Vertex3D getVertex() {

        return vertex;
    }

    public void setVertex(Vertex3D vertex) {
        this.vertex = vertex;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        //TODO < 0
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        //TODO < 0
        this.height = height;
    }

    public int getDepth() {
        return depth;
    }

    public void setDepth(int depth) {
        //TODO < 0
        this.depth = depth;
    }

    @Override
    public double getArea() {
        return 2 * this.getWidth() * this.getHeight()
                + 2 * this.getWidth() * this.getDepth()
                + 2 * this.getHeight() * this.getDepth();
    }

    @Override
    public double getVolume(){
        return this.getWidth() * this.getHeight() * this.getDepth();
    }

    @Override
    public String toString() {
        return "Cuboid => Height: "
                +this.getHeight()
                +" Width: "+this.getWidth()
                +" Depth: "+this.getDepth()
                +" Vertex: ("+this.getVertex().getX()
                                +","+this.getVertex().getY()
                                +","+this.getVertex().getZ()+")"
                +" Area: "+this.getArea()
                +" Volume: "+this.getVolume();

    }
}
