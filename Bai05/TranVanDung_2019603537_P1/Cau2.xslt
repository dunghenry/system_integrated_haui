<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <html>
            <head> 
                <title>Sinh vien </title>    
            </head>
            <body> 
                <h1>Danh sach sinh vien</h1>
                <table border="1"> 
                    <tr> 
                        <th>STT</th>    
                        <th>Masv</th>    
                        <th>Tensv</th>    
                        <th>GioiTinh</th>    
                        <th>NgaySinh</th>    
                        <th>MaLop</th>    
                    </tr>
                    <xsl:for-each select="DSSV/SinhVien">
                        <xsl:sort select="TenSv" />
                            <tr>
                                <td><xsl:value-of select="position()"/></td>
                                <td><xsl:value-of select="MaSv"/></td>
                                <td><xsl:value-of select="TenSv"/></td>
                                <td><xsl:value-of select="GioiTinh"/></td>
                                <td><xsl:value-of select="NgaySinh"/></td>
                                <td><xsl:value-of select="MaLop"/></td>
                            </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>