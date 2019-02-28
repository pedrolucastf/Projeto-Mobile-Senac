using System;
using System.Collections.Generic;
using System.Text;

namespace AppProjeto
{

    public class PC
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string titulo { get; set; }
        public Vendedor vendedor { get; set; }
        public int price { get; set; }
        public string currency_id { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public string stop_time { get; set; }
        public string condicao { get; set; }
        public string permalink { get; set; }
        public string miniatura { get; set; }
        public bool accept_mercadopago { get; set; }
        public Parcelas parcelas { get; set; }
        public Address address { get; set; }
        public Envio envio { get; set; }
        public Seller_Address seller_address { get; set; }
        public Atributo[] atributos { get; set; }
        public object original_price { get; set; }
        public string category_id { get; set; }
        public object official_store_id { get; set; }
        public object catalog_product_id { get; set; }
        public Reviews reviews { get; set; }
        public string[] tags { get; set; }
    }

    public class Vendedor
    {
        public int id { get; set; }
        public string power_seller_status { get; set; }
        public string car_dealer { get; set; }
        public string real_estate_agency { get; set; }
        public object[] tags { get; set; }
    }

    public class Parcelas
    {
        public int quantity { get; set; }
        public float amount { get; set; }
        public int rate { get; set; }
        public string currency_id { get; set; }
    }

    public class Address
    {
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string city_id { get; set; }
        public string city_name { get; set; }
    }

    public class Envio
    {
        public string free_shipping { get; set; }
        public string mode { get; set; }
        public object[] tags { get; set; }
        public string logistic_type { get; set; }
        public string store_pick_up { get; set; }
    }

    public class Seller_Address
    {
        public string id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public País país { get; set; }
        public State state { get; set; }
        public Cidade cidade { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class País
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State
    {
        public string id { get; set; }
        public string nome { get; set; }
    }

    public class Cidade
    {
        public string id { get; set; }
        public string nome { get; set; }
    }

    public class Reviews
    {
        public float rating_average { get; set; }
        public int total { get; set; }
    }

    public class Atributo
    {
        public object value_struct { get; set; }
        public string attribute_group_id { get; set; }
        public string attribute_group_name { get; set; }
        public int fonte { get; set; }
        public string id { get; set; }
        public string nome { get; set; }
        public string valor_id { get; set; }
        public string value_name { get; set; }
    }

}
