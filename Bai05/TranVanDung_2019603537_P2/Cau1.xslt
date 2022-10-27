<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/" >
        <table>
            <tr> 
                <td>BENH VIEN DA KHOA</td>
                <td>&#032;</td>
                <td>&#032;</td>
                <td>&#032;</td>
                <th> DANH SACH BENH NHAN </th>
            </tr>    
        </table>
        
        <xsl:for-each select="DSK/Khoa">
            <table>
                <tr> 
                    <td>Khoa: <xsl:value-of select="TenKhoa"/></td>
                    <td>&#032;</td>
                    <td>&#032;</td>
                    <td>&#032;</td>
                    <td>Phong : <xsl:value-of select="Phong"/></td>
                </tr>
            </table>
            <br/>
            <table border="1" style="border-collapse: collapse">
                <tr>
                    <td>Mã số BN</td>    
                    <td>Họ tên</td>    
                    <td>Ngày nhập viện</td>    
                    <td>Số ngày điều trị</td>    
                    <td>Số tiền phải trả</td>    
                </tr>
                <xsl:for-each select="DSBN/BenhNhan">
                    <tr>
                        <td><xsl:value-of select="@MSBN"/></td>    
                        <td><xsl:value-of select="HoTen"/></td>    
                        <td><xsl:value-of select="NgayNhapVien"/></td>    
                        <td><xsl:value-of select="SoNgayNamVien"/></td>    
                        <td><xsl:value-of select="SoNgayNamVien * 150000"/></td>    
                    </tr>
                </xsl:for-each>
            </table>
            <br/>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>