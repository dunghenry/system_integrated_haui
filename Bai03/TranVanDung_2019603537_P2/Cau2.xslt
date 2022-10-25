<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/" >
        <html>
            <head>
                <title>Benh vien da khoa</title>
            </head>
            <style> 
               
            </style>
            <body>
                <table>
                    <tr> 
                        <td>BENH VIEN DA KHOA</td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <th>DANH SACH BENH NHAN</th>
                    </tr>               
                </table>
                <table border="2">
                    <tr>
                        <td>STT</td>    
                        <td>Ho Ten</td>    
                        <td>Ngay nhap vien</td>    
                        <td>So ngay dieu tri</td>    
                        <td>So tien phai tra</td>    
                    </tr>
                    <xsl:for-each select="DSK/Khoa/DSBN/BenhNhan">
                        <tr>
                            <td> <xsl:value-of select="position()"/></td>
                            <td><xsl:value-of select="HoTen"/></td>
                            <td><xsl:value-of select="NgayNhapVien"/></td>
                            <td><xsl:value-of select="SoNgayNamVien"/></td>
                            <td><xsl:value-of select="SoNgayNamVien * 15000"/></td>
                            
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

    

</xsl:stylesheet>