using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace StockProduct;

public class AddProductStock
{
    public MySqlConnection Connection;
    

    public AddProductStock()
    {
        this.Connection = DatabaseConnection.getConnection();
    }
    
    public void addProduct(string product, string price, string quantity)
    {
        MySqlCommand command = Connection.CreateCommand();
        command.CommandText = $"INSERT INTO product (`product`, `price`, `quantity`) VALUES ('{product}','{price}', '{quantity}')";
        
            Connection.Open();
            
            command.ExecuteNonQuery();
        Connection.Close();
    }

    
}