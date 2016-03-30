package com.company.shapes;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        SpaceShape sp = new SquarePyramid(new Vertex3D(1,1,1),3,5);
        SpaceShape cuboid = new Cuboid(new Vertex3D(1,2,3),4,2,5);
        SpaceShape sphere = new Sphere(new Vertex3D(2,3,4),10);

        PlaneShape triangle = new Triangle(new Vertex2D(1,2),new Vertex2D(5,3),new Vertex2D(6,10));
        PlaneShape rectangle = new Rectangle(new Vertex2D(3,3),20,30);
        PlaneShape circle = new Circle(new Vertex2D(6,6),15);

        List<Shape> shapes = new ArrayList<>();
        shapes.add(sp);
        shapes.add(cuboid);
        shapes.add(sphere);
        shapes.add(triangle);
        shapes.add(rectangle);
        shapes.add(circle);

        for (int i = 0; i < shapes.size(); i++) {
            System.out.println(shapes.get(i));
        }
        System.out.println("---");
        System.out.println("---Shapes with volume > 40");
        shapes.stream()
                .filter(x -> x instanceof SpaceShape)
                .map(x -> (SpaceShape) x)
                .filter(x -> x.getVolume() > 40)
                .forEach(System.out::println);
        System.out.println("---");
        System.out.println("---Plane Shapes ordered by perimeter ascending");
        shapes.stream()
                .filter(x -> x instanceof PlaneShape)
                .map(x -> (PlaneShape) x)
                .sorted((x1, x2) -> x1.compareTo(x2))
                .forEach(System.out::println);


    }

    }

