﻿using Leuka.Models.Generated;
using static Leuka.Core.Constants;

namespace Leuka.Core.ViewModels.Shared
{
    public class SplitBlockViewModel : IContentViewModel
    {
        public SplitBlockViewModel(SplitBlock splitBlock)
        {
            Title = splitBlock.Title;
            Description = splitBlock.Description;
            Tag = splitBlock.Tag;
            Image = new ImageViewModel(splitBlock.Image);
            Buttons = splitBlock.Button.Select(x => new ButtonViewModel(x));
            Alignment = splitBlock.Alignment;
            ComponentClass = splitBlock.BackgroundColor == Colors.Blue
                ? "bg-lighblue"
                : string.Empty;

            var separator = splitBlock.Separator.FirstOrDefault();

            if (separator != null)
            {
                Separator = new SeparatorViewModel(separator);
            }
        }

        public string Title { get; }
        public string Description { get; }
        public string Tag { get; }
        public ImageViewModel Image { get; }
        public SeparatorViewModel Separator { get; }
        public IEnumerable<ButtonViewModel> Buttons { get; }
        public string Alignment { get; }
        public string ComponentClass { get; }

        public string PartialViewPath => "~/Views/Partials/NestedContent/_SplitBlock.cshtml";
    }
}
