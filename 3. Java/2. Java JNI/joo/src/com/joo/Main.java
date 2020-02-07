package com.joo;

import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        Paire paire = new Paire("toto", "tata");
        System.out.println(paire.getValeur1());

        try {
            Class<?> c = paire.getClass();
            Field field = c.getField("valeur1");
            Object result = field.get(paire);
            Method method = c.getMethod("getValeur1");
            System.out.println(method.invoke(paire));


        } catch (IllegalAccessException | NoSuchMethodException | InvocationTargetException | NoSuchFieldException e) {

        }
    }
}
