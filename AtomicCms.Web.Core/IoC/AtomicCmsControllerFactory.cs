namespace AtomicCms.Web.Core.IoC
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    //自定义的控制器工厂
    public class AtomicCmsControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return IoC.Get(controllerType) as IController;
        }
    }
}