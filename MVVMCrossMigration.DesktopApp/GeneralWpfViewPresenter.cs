using MvvmCross.Platforms.Wpf.Presenters;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMCrossMigration.DesktopApp
{
    public class GeneralWpfViewPresenter : MvxWpfViewPresenter
    {
        public GeneralWpfViewPresenter(ContentControl contentControl) : base(contentControl)
        {

        }

        //public override MvxBasePresentationAttribute GetPresentationAttribute(MvxViewModelRequest request)
        //{
        //    var viewType = ViewsContainer.GetViewType(request.ViewModelType);

        //    var overrideAttribute = GetOverridePresentationAttribute(request, viewType);
        //    if (overrideAttribute != null)
        //        return overrideAttribute;

        //    var attribute = viewType
        //        .GetCustomAttributes(typeof(MvxBasePresentationAttribute), true)
        //        .FirstOrDefault() as MvxBasePresentationAttribute;

        //    if (attribute != null)
        //    {
        //        if (attribute.ViewType == null)
        //            attribute.ViewType = viewType;

        //        if (attribute.ViewModelType == null)
        //            attribute.ViewModelType = request.ViewModelType;

        //        return attribute;
        //    }

        //    return CreatePresentationAttribute(request.ViewModelType, viewType);

        //}

        //protected override MvxPresentationAttributeAction GetPresentationAttributeAction(MvxViewModelRequest request, out MvxBasePresentationAttribute attribute)
        //{
        //    attribute = GetPresentationAttribute(request);
        //    attribute.ViewModelType = request.ViewModelType;
        //    var viewType = attribute.ViewType;
        //    var attributeType = attribute.GetType();

        //    if (AttributeTypesToActionsDictionary.TryGetValue(
        //        attributeType,
        //        out MvxPresentationAttributeAction attributeAction))
        //    {
        //        if (attributeAction.ShowAction == null)
        //            throw new NullReferenceException($"attributeAction.ShowAction is null for attribute: {attributeType.Name}");

        //        if (attributeAction.CloseAction == null)
        //            throw new NullReferenceException($"attributeAction.CloseAction is null for attribute: {attributeType.Name}");

        //        return attributeAction;
        //    }

        //    throw new KeyNotFoundException($"The type {attributeType.Name} is not configured in the presenter dictionary");

        //}


        public override Task<bool> Show(MvxViewModelRequest request)
        {
            return GetPresentationAttributeAction(request, out MvxBasePresentationAttribute attribute).ShowAction.Invoke(attribute.ViewType, attribute, request);
        }
    }

}
