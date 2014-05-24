///////////////////////////////////////
#region Namespace Directives

using System.ComponentModel;

#endregion
////////////////////////////////////////

// The gist of code in this file was originally excerpted from:
// "How To: Implement Property Changed Notification" found at http://msdn.microsoft.com/en-us/library/ms743695.aspx on 1/2/2013.
// Code from those same excerpts was updated when the article was re-accessed on 4/12/2014.

namespace WpfHelper.PropertyChanged
{
    /// <summary>
    /// Handles Property change notifications for derived classes.
    /// </summary>
    public abstract class propertyChangedNotificationHandling : INotifyPropertyChanged
    {
        ////////////////////////////////////////
        #region Public Event Declarations

        /// <summary>
        /// Handler for the property changed event.
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        #endregion

        ////////////////////////////////////////
        #region Protected Methods

        /// <summary>
        /// Handles notification event raised when properties for this object are modified.
        /// </summary>
        /// <param name="propertyName">Name of the property for which notifications are created upon change.</param>
        /// <returns>Whether or not the property change notifier was successfully fired.</returns>
        protected virtual bool OnPropertyChanged(string propertyName)
        {
            bool handledSuccessfully = false;
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                handledSuccessfully = true;
            }
            else
            {
                handledSuccessfully = false;
            }

            return handledSuccessfully;
        }

        #endregion
    }
}
