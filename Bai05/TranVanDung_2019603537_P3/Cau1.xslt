<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/">
        <table border="1"> 
            <tr>
                <th>MaMh</th>
                <th>TenMh</th>
                <th>SoGio</th>
            </tr>
            <xsl:for-each select="DSMH/MonHoc">
                <xsl:if test="SoGio &gt;= 40">
                    <tr>
                        <td><xsl:value-of select="MaMh"/></td>
                        <td><xsl:value-of select="TenMh"/></td>
                        <td><xsl:value-of select="SoGio"/></td>
                    </tr>
                </xsl:if>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>