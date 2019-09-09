package com.sdzee.servlets;

import com.sdzee.beans.Coyote;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

public class Test extends HttpServlet {

    public void doGet(HttpServletRequest request, HttpServletResponse response ) throws ServletException, IOException {

        String paramAuteur= request.getParameter("auteur");
        String message = "Transmission de ariables : OK !" + paramAuteur;
        Coyote premierBean = new Coyote();

        premierBean.setNom("Coyote");
        premierBean.setPrenom("While E.");

        request.setAttribute("test",message);
        request.setAttribute("coyote",premierBean);

        this.getServletContext().getRequestDispatcher("/WEB-INF/test.jsp").forward(request,response);
    }
}
