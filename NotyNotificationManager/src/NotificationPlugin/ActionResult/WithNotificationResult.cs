using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NotyNotification.Extension;
using NotyNotification.Model;

namespace NotyNotification.ActionResult
{
    public class WithNotificationResult : System.Web.Mvc.ActionResult
    {
        private readonly System.Web.Mvc.ActionResult _result;

        private readonly AlertType _alertType;
        private readonly String _message;
        private readonly Position _position;
        private readonly bool _animation;
        private readonly bool _modal;
        private readonly int _timeout;

        public WithNotificationResult(System.Web.Mvc.ActionResult result,
            String message, Position position, AlertType alertType, int timeOut, bool animation, bool modal)
        {
            this._result = result;
            this._message = message;
            this._position = position;
            this._animation = animation;
            this._modal = modal;
            this._alertType = alertType;
            this._timeout = timeOut;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            // Add the notification
            context.Controller.Notifications().Add(_message, _position, _alertType, _timeout, _animation, _modal);

            // Continue with execution
            _result.ExecuteResult(context);
        }
    }
}
