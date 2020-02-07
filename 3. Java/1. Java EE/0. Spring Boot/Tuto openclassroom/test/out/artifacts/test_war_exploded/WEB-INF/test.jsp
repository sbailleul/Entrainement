<%@ page import="com.sdzee.beans.Coyote" %><%--
  Created by IntelliJ IDEA.
  User: baill
  Date: 09/09/2019
  Time: 21:51
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Test</title>
</head>
<body>
    <p>
    Ceci est une page générée depuis une JSP
    </p>
    <p>
        <%
            String attribut = (String) request.getAttribute("test");
            out.println(attribut);
            Coyote notreBean = (Coyote) request.getAttribute("coyote");
            out.println(notreBean.getPrenom());
            out.println(notreBean.getNom());
        %>
    </p>
</body>
</html>
