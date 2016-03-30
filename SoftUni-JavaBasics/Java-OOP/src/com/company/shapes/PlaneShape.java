package com.company.shapes;


import java.util.List;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable{
    private List<Vertex2D> vertices;

    public abstract int compareTo(Object obj);
}
