package com.ecommerce.microcommerce.web.controller;

import com.ecommerce.microcommerce.model.Product;
import org.springframework.web.bind.annotation.*;

@RestController
public class ProductController {
    @GetMapping(value="/Produits")
    public String listeProduits(){
        return "un exemple de produit";
    }

    @GetMapping(value="/Produits/{id}")
    public Product afficherUnProduit(@PathVariable int id){
        return new Product(id,new String("Aspirateur"),100);
    }
}
