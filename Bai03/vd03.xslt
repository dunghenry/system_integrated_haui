<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <html>
            <head> 
                <title>Vi du ve choose</title>    
            </head>    
            <body>
                <b><h2>Danh sach sinh vien </h2></b>
                <xsl:for-each select="/DSSV/sv">
                    <xsl:variable name="biendiem" select="diem"> </xsl:variable>
                    <b>Ma SV: </b>
                    <xsl:value-of select="@masv"/>
                    <br></br>
                    <b>Ho ten: </b>
                    <xsl:value-of select="hoten"/>
                    <br> </br>
                    <b>Diem: </b>
                    <xsl:value-of select="diem"/>
                    <br> </br>
                    <b>Diem bang chu: </b>
                    <xsl:choose>
                        <xsl:when test="$biendiem&lt;5">
                            Kem
                        </xsl:when>
                        <xsl:when test="$biendiem&gt;8">
                            Gioi
                        </xsl:when>
                    </xsl:choose>
                    <br></br>
                    <hr></hr>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>

    

</xsl:stylesheet>