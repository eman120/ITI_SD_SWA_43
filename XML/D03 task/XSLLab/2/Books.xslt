<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">

<xsl:template match="books">
<h1>A List of Books</h1>
<table border="1px">
	<tbody>
		<tr bgcolor="purple">
			<th>No.</th>     
			<th colspan="5">Author</th>
			<th colspan="5">Title</th>
			<th colspan="3">Price</th>
		</tr>
		<xsl:for-each select="book">
			 <tr>
				  <td><xsl:value-of select="position()"></xsl:value-of></td>
				  <td colspan="5"><xsl:value-of select="author"/></td>
				  <td colspan="5"><xsl:value-of select="title"/></td>
				  <td colspan="3"><xsl:value-of select="price"/></td>
		    </tr>
		</xsl:for-each>
		
	</tbody>
</table>

</xsl:template>


</xsl:stylesheet>
