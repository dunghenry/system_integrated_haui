<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <html>
            <head>
                <title>Lop Hoc</title>    
            </head>
            <body>
                <h1>Danh sach lop hoc </h1>    
                <table border="1"> 
                <html> 
                    <th>MaLop</th>    
                    <th>TenLop</th>    
                </html>   
                <xsl:for-each select="DSLH/LopHoc">
                    <tr>
                        <td><xsl:value-of select="MaLop"/> </td>
                        <td><xsl:value-of select="TenLop"/> </td>
                    </tr>
                </xsl:for-each>
            </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>