export class Item {
  public Title: string;
  public Subtitle: string;
  public Authors: string[];
  public Publisher: string;
  public PublishedDate: string;
  public Description: string;
  public Categories: string[];

  constructor(
      title: string,
      subtitle: string,
      authors: string[],
      publisher: string,
      publishedDate: string,
      description: string,
      categories: string[]
  ) {
      this.Title = title;
      this.Subtitle = subtitle;
      this.Authors = authors;
      this.Publisher = publisher;
      this.PublishedDate = publishedDate;
      this.Description = description;
      this.Categories = categories;
  }
}