package com.sdzee.beans;

public class Coyote {

    private String nom;
    private String prenom;
    private boolean genius;

    public Coyote() {
    }

    public Coyote(String nom, String prenom, boolean genius) {
        this.nom = nom;
        this.prenom = prenom;
        this.genius = genius;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }

    public boolean isGenius() {
        return genius;
    }

    public void setGenius(boolean genius) {
        this.genius = true;
    }
}
