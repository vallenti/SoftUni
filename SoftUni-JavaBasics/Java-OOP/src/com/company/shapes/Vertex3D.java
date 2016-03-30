package com.company.shapes;


public class Vertex3D extends Vertex {
    private int x;
    private int y;
    private int z;

    public Vertex3D(int x, int y, int z) {
        setX(x);
        setY(y);
        setZ(z);
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
    public int getZ() {
        return z;
    }

    public void setZ(int z) {
        this.z = z;
    }
}
