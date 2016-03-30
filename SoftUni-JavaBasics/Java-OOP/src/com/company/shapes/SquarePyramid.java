package com.company.shapes;

public class SquarePyramid extends SpaceShape {

    private Vertex3D baseCenter;
    private int baseWidth;
    private int pyramidHeight;

    public Vertex3D getBaseCenter() {
        return baseCenter;
    }

    public void setBaseCenter(Vertex3D baseCenter) {
        this.baseCenter = baseCenter;
    }

    public int getBaseWidth() {
        return baseWidth;
    }

    public void setBaseWidth(int baseWidth) {
        //TODO <0
        this.baseWidth = baseWidth;
    }

    public int getPyramidHeight() {
        return pyramidHeight;
    }

    public void setPyramidHeight(int pyramidHeight) {
        //TODO <0
        this.pyramidHeight = pyramidHeight;
    }



    public SquarePyramid(Vertex3D baseCenter, int baseWidth, int pyramidHeight) {
        setBaseCenter(baseCenter);
        setBaseWidth(baseWidth);
        setPyramidHeight(pyramidHeight);
    }

    @Override
    public double getArea() {
        return 2 * this.getBaseWidth()*this.getPyramidHeight() + Math.pow(this.getBaseWidth(),2);
    }

    @Override
    public double getVolume() {
        return (this.getBaseWidth() * this.getBaseWidth() * this.getPyramidHeight()) / 3;
    }

    @Override
    public String toString(){
        return "Square pyramid => Vertex: ("
                +this.getBaseCenter().getX()+","+this.getBaseCenter().getY()+","+this.getBaseCenter().getZ()+")"
                +" Base width: "+this.getBaseWidth()
                +" Height: "+this.getPyramidHeight()
                +" Area: "+this.getArea()
                +" Volume: "+this.getVolume();
    }
}
