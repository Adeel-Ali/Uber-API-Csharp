/*
 * UberAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/13/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UberAPI.PCL;

namespace UberAPI.PCL.Models
{
    public class GetTimeEstimatesInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private double startLatitude;
        private double startLongitude;
        private string customerUuid;
        private string productId;

        /// <summary>
        /// Latitude component of the start location
        /// </summary>
        [JsonProperty("start_latitude")]
        public double StartLatitude 
        { 
            get 
            {
                return this.startLatitude; 
            } 
            set 
            {
                this.startLatitude = value;
                onPropertyChanged("StartLatitude");
            }
        }

        /// <summary>
        /// Longitude component of the start location
        /// </summary>
        [JsonProperty("start_longitude")]
        public double StartLongitude 
        { 
            get 
            {
                return this.startLongitude; 
            } 
            set 
            {
                this.startLongitude = value;
                onPropertyChanged("StartLongitude");
            }
        }

        /// <summary>
        /// The customer id interested in estimate
        /// </summary>
        [JsonProperty("customer_uuid")]
        public string CustomerUuid 
        { 
            get 
            {
                return this.customerUuid; 
            } 
            set 
            {
                this.customerUuid = value;
                onPropertyChanged("CustomerUuid");
            }
        }

        /// <summary>
        /// Id of the requested product
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId 
        { 
            get 
            {
                return this.productId; 
            } 
            set 
            {
                this.productId = value;
                onPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 