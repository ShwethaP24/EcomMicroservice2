using System;

namespace EcomMicroservice2.Models
{
    public static class QueryStringClass
    {
        public static string getDistinctSegmentProduct = "select DISTINCT SEGMENT, SEGMENT_NAME from XXIBM_PRODUCT_CATALOGUE ";
        public static string getDistinctFamilyProduct = "select DISTINCT FAMILY, FAMILY_NAME from XXIBM_PRODUCT_CATALOGUE WHERE SEGMENT=@SEGMENT";
        public static string getDistinctClassProduct = "select DISTINCT CLASS, CLASS_NAME from XXIBM_PRODUCT_CATALOGUE WHERE FAMILY=@FAMILY";
        public static string getDistinctCommodityProduct = "select DISTINCT COMMODITY, COMMODITY_NAME from XXIBM_PRODUCT_CATALOGUE WHERE CLASS=@CLASS";
        public static string getDistinctBrandProduct = "select ITEM_NO,DESCRIPTION, LONG_DESCRIPTION, CATALOGUE_CATEGORY,BRAND from XXIBM_PRODUCT_STYLE ";

        public static string getAllProductWithDetails = " Select  COMMODITY, COMMODITY_NAME,SKU.ITEM_NUMBER, SKU.DESCRIPTION,SKU.LONG_DESCRIPTION,BRAND,SKUAtt_Value1 AS SIZE, SKUAtt_Value2 AS COLOUR, LIST_PRICE,DISCOUNT,INSTOCK,PRICE_EFFECTIVE_DATE " +
                                                        " FROM XXIBM_PRODUCT_CATALOGUE AS CATALOGUE " +
                                                        " INNER JOIN XXIBM_PRODUCT_SKU AS SKU ON CATALOGUE.COMMODITY = SKU.CATALOGUE_CATEGORY " +
                                                        " INNER JOIN XXIBM_PRODUCT_STYLE AS STYLE ON STYLE.CATALOGUE_CATEGORY = SKU.CATALOGUE_CATEGORY "+
                                                        " INNER JOIN XXIBM_PRODUCT_PRICING AS PRICING ON PRICING.ITEM_NUMBER = SKU.ITEM_NUMBER ";





    }
}