<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <table border="1"> 
            <tr>
                <th>MaSv</th>
                <th>MaMh</th>
                <th>DiemThi</th>
            </tr>
            <xsl:for-each select="DSMH/MonHoc">
                <xsl:if test="MaMh='THVP'and DiemThi>=5">
                    <tr>
                        <td><xsl:value-of select="MaSv"/></td>
                        <td><xsl:value-of select="MaMh"/></td>
                        <td><xsl:value-of select="DiemThi"/></td>
                    </tr>
                </xsl:if>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>