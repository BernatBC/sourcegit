using Avalonia.Media.Imaging;

            if (!revert && !isTracked)
                builder.Append("new file mode 100644\n");
            if (selection.StartLine != 1)
                additions++;
                    if (line.Type != TextDiffLineType.Added)
                        continue;
                    if (line.Type != TextDiffLineType.Added)
                        continue;
                        if (line.Type == TextDiffLineType.Indicator)
                            break;
                        if (revert)
                            builder.Append("\n ").Append(line.Content);
                        if (!revert)
                            builder.Append("\n ").Append(line.Content);
                        if (line.Type == TextDiffLineType.Indicator)
                            break;
                        if (revert)
                            builder.Append("\n ").Append(line.Content);
                        if (!revert)
                            builder.Append("\n ").Append(line.Content);
                if (test.Type == TextDiffLineType.Indicator)
                    break;
            if (oldCount == 0 && newCount == 0)
                return false;
                if (test.Type == TextDiffLineType.Indicator)
                    break;
            if (oldCount == 0 && newCount == 0)
                return false;
    public class ImageDiff
    {
        public Bitmap Old { get; set; } = null;
        public Bitmap New { get; set; } = null;

        public string OldSize => Old != null ? $"{Old.PixelSize.Width} x {Old.PixelSize.Height}" : "0 x 0";
        public string NewSize => New != null ? $"{New.PixelSize.Width} x {New.PixelSize.Height}" : "0 x 0";
    }

    public class NoOrEOLChange
    {
    }

}