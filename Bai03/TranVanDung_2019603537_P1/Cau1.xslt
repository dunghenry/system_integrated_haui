<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/" >
       <html>
            <head>
                <title>Danh muc hoa don</title>
            </head>
            <style> 
                h3{
                    padding:0;
                    margin:0;
                   
                }  
                h3.nguoigiao{
                    margin-left: 200px;
                }
                h3.kiten{
                    margin-left: 185px;
                }
            </style>
            <body>
                <h2>Phieu Mua Hang</h2>
                <table>
                    <tr> 
                        <td> Hoa don:<xsl:value-of select="DS/HoaDon/MaHD" /> </td>
                        <td> Ngayban:<xsl:value-of select="DS/HoaDon/NgayBan" /> </td>  
                    </tr>
                    <tr> 
                       <td>Loai hang:<xsl:value-of select="DS/HoaDon/LoaiHang/@TenLoai" /> </td>
                    </tr>
                </table>
                <table border="1">
                    <tr> 
                        <th>Ma hang</th>
                        <th>Ten hang</th>
                        <th>So luong</th>
                        <th>Don gia</th>
                        <th>Thanh tien</th>
                    </tr>
                    <xsl:for-each select="DS/HoaDon/LoaiHang/Hang"> 
                        <xsl:if test="SoLuong>60">
                            <tr> 
                                <td><xsl:value-of select="@MaHang"/></td>
                                <td><xsl:value-of select="TenHang"/></td>
                                <td><xsl:value-of select="SoLuong"/></td>
                                <td><xsl:value-of select="DonGia"/></td>
                                <td><xsl:value-of select="SoLuong*DonGia"/></td>
                            </tr>
                        </xsl:if>
                     
                    </xsl:for-each>
                </table>
                <h3 class="nguoigiao">Nguoi giao</h3>
                <h3 class="kiten"><xsl:value-of select="DS/HoaDon/NguoiGiao"/></h3>
            </body>
        </html>
    </xsl:template>

    

</xsl:stylesheet>