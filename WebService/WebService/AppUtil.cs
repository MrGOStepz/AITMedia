using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel;

namespace WebService
{
    public static class AppUtil
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();

            dt.TableName = "wsTable"; // Web service table
            
            //Prepare table structure
            //for each property class T has, add as column datatable
            for (int i = 0; i < props.Count; i  ++)
            {
                PropertyDescriptor pd = props[i]; //one of the properties of class T
                dt.Columns.Add(pd.Name, pd.PropertyType); //new column of property name
                                               //and the type of this column is the same
                                                //as the property
                                            //w.g UserID, int
            }

            //Creating generic array of size (Number od properties)
            //Insert Data
            object[] RowOfDataAsObject = new object[props.Count];
                //represents a whole row of data gotten from our data parameter to add to our datatable

            //Cycle throgh all our data in our data list (e.g each userModel in List<UserModel>
            foreach (T item in data)
            {
                //Cycle through all of the values in each of the items properties (e.g UserID in userMedel)
                for (int i = 0; i < RowOfDataAsObject.Length; i++)
                {
                    //Copy riw values into objects array
                    RowOfDataAsObject[i] = props[i].GetValue(item);
                }
                //add objects array as new row into datable
                dt.Rows.Add(RowOfDataAsObject);           
            }
            return dt;
            
        }
    }
}