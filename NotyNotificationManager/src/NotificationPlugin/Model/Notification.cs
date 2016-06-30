using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotyNotification.Model
{
    public class Notification
    {
        public AlertType AlertType { get; set; }
        public String Message { get; set; }
        public Position Position { get; set; }
        public bool Animation { get; set; }
        public bool Modal { get; set; }
        /// <summary>
        /// Time out set in milleseconds.
        /// </summary>
        public int TimeOut { get; set; }
    }


    /// <summary>
    /// Capitalization is intended as it is used for the jQuery call.
    /// </summary>
    public enum Position
    {
        top = 0,
        bottom = 1,
        topLeft = 2,
        topRight = 3,
        topCenter = 4,
        center = 5,
        centerLeft = 6,
        centerRight = 7, 
        bottomLeft = 8,
        bottomCenter = 9,
        bottomRight = 10
    }

    /// <summary>
    /// Capitalization is intended as it is used for the jQuery call.
    /// </summary>
    public enum AlertType
    {
        alert = 0,
        success = 1,
        error = 2,
        warning = 3,
        information = 4,
        confirm = 5

    }

}
