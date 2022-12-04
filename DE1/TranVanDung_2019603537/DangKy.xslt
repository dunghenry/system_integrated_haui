<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/DangKy.xsd"
>
	<xsl:output method="html" indent="yes"/>
	<xsl:template match="/">
		<html>
			<head>
				<title>Danh sách đăng ký nghỉ</title>
			</head>
			<body>
				<h1> Danh sách đăng ký nghỉ </h1>
				<xsl:for-each select="a:DangKy">
					<table border="1">
						<tr>
							<th>STT</th>
							<th>Mã NV</th>
							<th>Lý do</th>
							<th>Đơn vị</th>
							<th>Trạng Thái</th>
							<th>Chi chú</th>
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
										<xsl:value-of select="a:LyDo" />
									</td>
									<td>
										<xsl:value-of select="a:DonVi" />
									</td>
									<td>
										<xsl:value-of select="a:TrangThai" />
									</td>
									<td style="text-align:center">
										
										<xsl:choose>
											<xsl:when test="a:DonVi = 0.5">
												Nghỉ nửa ngày
											</xsl:when>
											<xsl:otherwise>
												
											</xsl:otherwise>
										</xsl:choose>
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
