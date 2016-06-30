using System;
using System.Web.Mvc;
using NotyNotification.ActionResult;
using NotyNotification.Model;

namespace NotyNotification.Extension
{
    public static class NotificationExtensions
    {
        /// <summary>
        /// Creates a notification, once the screen refreshes and will automatically appear based on Position.
        /// </summary>
        /// <param name="actionResult"></param>
        /// <param name="message"></param>
        /// <param name="position"></param>
        /// <param name="alertType"></param>
        /// <param name="timeOut">Time in milliseconds</param>
        /// <param name="animation"></param>
        /// <param name="modal"></param>
        /// <returns></returns>
        public static System.Web.Mvc.ActionResult WithNotification(
            this System.Web.Mvc.ActionResult actionResult, String message, Position position = Position.topRight,
            AlertType alertType = AlertType.information,
            int timeOut = 2000,
            bool animation = true,
            bool modal = false)
        {
            return new WithNotificationResult(actionResult, message, position, alertType, timeOut, animation, modal);
        }
        
        public static Notifications Notifications(this ControllerBase controller)
        {
            return new Notifications(controller.TempData);
        }
        
        public static Notifications Notifications(this HtmlHelper htmlHelper)
        {
            return new Notifications(htmlHelper.ViewContext.TempData);
        }
    }
}
