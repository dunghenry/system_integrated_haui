<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/ChamCong.xsd"
>
	<xsl:output method="html" indent="yes"/>
	<xsl:template match="/">
		<html>
			<head>
				<title>Bang cham cong</title>
			</head>
			<body>
				<h1> Bảng chấm công </h1>
				<xsl:for-each select="a:ChamCong">
					<table border="1">
						<tr>
							<th>STT</th>
							<th>Mã NV</th>
							<th>Ca làm việc</th>
							<th>Giờ vào</th>
							<th>Giờ ra</th>
							<th>Làm đêm</th>
						</tr>
						<xsl:for-each select="a:NgayLamViec">
							<tr>
								<td colspan="6" style="font-weight:bold">
									Ngày làm việc: <xsl:value-of select="@Ngay"/>
								</td>
							</tr>
							<xsl:for-each select="a:NhanVien">
								<tr>
									<td>
										<xsl:value-of select="position()" />
									</td>
									<td>
										<xsl:value-of select="@MaNV" />
									</td>
									<td style="text-align:center">
										<xsl:value-of select="a:CaLamViec" />
									</td>
									<td>
										<xsl:value-of select="a:GioVao" />
									</td>
									<td>
										<xsl:value-of select="a:GioRa" />
									</td>
									<td style="text-align:center">
										<xsl:if test="concat('',substring(a:GioVao,1,2)) &gt; 7 or concat('',substring(a:GioRa,1,2)) &lt; 20">
										</xsl:if>
										<xsl:if test="concat('',substring(a:GioVao,1,2)) &gt; 19 or concat('',substring(a:GioRa,1,2)) &lt; 8">
											x
										</xsl:if>
									</td>
								</tr>
							</xsl:for-each>
						</xsl:for-each>
					</table>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
