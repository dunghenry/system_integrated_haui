<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/bongda">
		<html>
			<head>
				<title>Các thần tượng bóng đá</title>
			</head>
			<body>
				<h2>Các nhân vật tiêu biểu bóng đá</h2>
				<table border="2" cellpadding="1">
					<tr>
						<td>Cầu thủ</td>
						<td>Số bàn thắng</td>
						<td>Số lần sút</td>
						<td>Số lần được tạo cơ hội</td>
					</tr>
					<xsl:for-each select="cauthu">
						<tr>
							<td>
								<xsl:value-of select="hoten"/>
							</td>
							<td>
								<xsl:value-of select="ghiban"/>
							</td>
							<td>
								<xsl:value-of select="sosut"/>
							</td>
							<td>
								<xsl:value-of select="cohoi"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
