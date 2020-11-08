<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"></xsl:output>

  <xsl:template match="/">
    <html>
      <body>
        <table>
          <TR>
            <th>Country</th>
            <th>Cost</th>
            <th>Marka</th>
            <th>Model</th>
            <th>Year</th>
            <th>Color</th>
          </TR>
          <xsl:for-each select ="AutoDataBase/auto">
            <tr>
              <td>
                <xsl:value-of select ="@Country"/>
              </td>
              <td>
                <xsl:value-of select ="@Cost"/>
              </td>
              <td>
                <xsl:value-of select ="@Marka"/>
              </td>
              <td>
                <xsl:value-of select ="@Model"/>
              </td>
              <td>
                <xsl:value-of select ="@Year"/>
              </td>
              <td>
                <xsl:value-of select ="@Color"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
