<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <html>
            <head>
                <title>Hoa Don Hang</title>
            </head>
            <body>
                <h1>Hoa Don Hang</h1>
                <xsl:for-each select="DSHD/HoaDon">
                    <h4>Ma hoa don: <xsl:value-of select="MaHoaDon"/></h4>
                    <h4>Ngay ban: <xsl:value-of select="NgayBan"/></h4>
                    
                    <xsl:for-each select="LoaiHang">
                        <h4>Ma loai hang: <xsl:value-of select="@MaLoai"/></h4>
                        <h4>Ten loai hang: <xsl:value-of select="@TenLoai"/></h4>
                        <xsl:for-each select="Hang">
                            <ul>
                                <li>Ma hang: <xsl:value-of select="@MaHang"/></li>
                                <li>Ten hang: <xsl:value-of select="Tenhang"/></li>
                                <li>So luong: <xsl:value-of select="Soluong"/></li>
                                <li>Don vi tinh: <xsl:value-of select="Donvitinh"/></li>
                                <li>Don gia: <xsl:value-of select="Dongia"/></li>
                            </ul>
                        </xsl:for-each>
                    </xsl:for-each>
                    <hr />
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>