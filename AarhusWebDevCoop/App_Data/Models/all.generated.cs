using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "d98e8ea19845b04f")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Description: A short description/summary of the content of this page.
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return this.GetPropertyValue<string>("metaDescription"); }
		}

		///<summary>
		/// Meta Keywords: The keywords of this page separated by comma (e.g. frontend development, JavaScript, CSS).
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return this.GetPropertyValue<string>("metaKeywords"); }
		}

		///<summary>
		/// Hide in Navigtion: Hide the page in the main menu.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Footer Text: The text in the footer.
		///</summary>
		[ImplementPropertyType("footerText")]
		public string FooterText
		{
			get { return this.GetPropertyValue<string>("footerText"); }
		}

		///<summary>
		/// Main Content: The main content of the homepage.
		///</summary>
		[ImplementPropertyType("homeContent")]
		public IHtmlString HomeContent
		{
			get { return this.GetPropertyValue<IHtmlString>("homeContent"); }
		}

		///<summary>
		/// Home Title: The title of the home page.
		///</summary>
		[ImplementPropertyType("homeTitle")]
		public string HomeTitle
		{
			get { return this.GetPropertyValue<string>("homeTitle"); }
		}

		///<summary>
		/// Show logo: Choose whether logo should be visible or not.
		///</summary>
		[ImplementPropertyType("showLogo")]
		public bool ShowLogo
		{
			get { return this.GetPropertyValue<bool>("showLogo"); }
		}

		///<summary>
		/// Use standard image for news articles: Turn standard image on or off.
		///</summary>
		[ImplementPropertyType("showStandardImageArticles")]
		public bool ShowStandardImageArticles
		{
			get { return this.GetPropertyValue<bool>("showStandardImageArticles"); }
		}

		///<summary>
		/// Use standard image for projects: Turn standard image on or off.
		///</summary>
		[ImplementPropertyType("showStandardImageProjects")]
		public bool ShowStandardImageProjects
		{
			get { return this.GetPropertyValue<bool>("showStandardImageProjects"); }
		}

		///<summary>
		/// Standard Image: The image in the header.
		///</summary>
		[ImplementPropertyType("standardImage")]
		public IPublishedContent StandardImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("standardImage"); }
		}

		///<summary>
		/// Standard Image - News articles: Standard Image for single news articles.
		///</summary>
		[ImplementPropertyType("standardImageArticles")]
		public IPublishedContent StandardImageArticles
		{
			get { return this.GetPropertyValue<IPublishedContent>("standardImageArticles"); }
		}

		///<summary>
		/// Standard Image - Projects: Standard Image for single projects
		///</summary>
		[ImplementPropertyType("standardImageProjects")]
		public IPublishedContent StandardImageProjects
		{
			get { return this.GetPropertyValue<IPublishedContent>("standardImageProjects"); }
		}

		///<summary>
		/// Website Logo: The logo of the website.
		///</summary>
		[ImplementPropertyType("websiteLogo")]
		public IPublishedContent WebsiteLogo
		{
			get { return this.GetPropertyValue<IPublishedContent>("websiteLogo"); }
		}

		///<summary>
		/// Website Title: The title of the website.
		///</summary>
		[ImplementPropertyType("websiteTitle")]
		public string WebsiteTitle
		{
			get { return this.GetPropertyValue<string>("websiteTitle"); }
		}
	}

	/// <summary>Articles Main</summary>
	[PublishedContentModel("articlesMain")]
	public partial class ArticlesMain : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articlesMain";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticlesMain(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesMain, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Articles List Description: The description of the articles' list page.
		///</summary>
		[ImplementPropertyType("articlesListDescription")]
		public IHtmlString ArticlesListDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("articlesListDescription"); }
		}

		///<summary>
		/// Articles List Title: The title of the articles' list page.
		///</summary>
		[ImplementPropertyType("articlesListTitle")]
		public string ArticlesListTitle
		{
			get { return this.GetPropertyValue<string>("articlesListTitle"); }
		}
	}

	/// <summary>Articles Item</summary>
	[PublishedContentModel("articlesItem")]
	public partial class ArticlesItem : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articlesItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticlesItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author: The author of the article.
		///</summary>
		[ImplementPropertyType("articleAuthor")]
		public string ArticleAuthor
		{
			get { return this.GetPropertyValue<string>("articleAuthor"); }
		}

		///<summary>
		/// Article Content: The main content of the article.
		///</summary>
		[ImplementPropertyType("articleItemContent")]
		public IHtmlString ArticleItemContent
		{
			get { return this.GetPropertyValue<IHtmlString>("articleItemContent"); }
		}

		///<summary>
		/// Article Main Image: The main image of the article.
		///</summary>
		[ImplementPropertyType("articleItemMainImage")]
		public IPublishedContent ArticleItemMainImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("articleItemMainImage"); }
		}

		///<summary>
		/// Article Title: The title of the article.
		///</summary>
		[ImplementPropertyType("articleItemTitle")]
		public string ArticleItemTitle
		{
			get { return this.GetPropertyValue<string>("articleItemTitle"); }
		}

		///<summary>
		/// Read More Link: Insert a link to the authors blog, website, originally posted website, etc.. E.g. http://www.yourwebsite.com
		///</summary>
		[ImplementPropertyType("articleReadMoreLink")]
		public string ArticleReadMoreLink
		{
			get { return this.GetPropertyValue<string>("articleReadMoreLink"); }
		}

		///<summary>
		/// Read More Title: The title of the link
		///</summary>
		[ImplementPropertyType("articleReadMoreTitle")]
		public string ArticleReadMoreTitle
		{
			get { return this.GetPropertyValue<string>("articleReadMoreTitle"); }
		}
	}

	/// <summary>Projects Main</summary>
	[PublishedContentModel("projectsMain")]
	public partial class ProjectsMain : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectsMain";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectsMain(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsMain, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Projects List Description: The description of the projects' list page.
		///</summary>
		[ImplementPropertyType("projectsListDescription")]
		public IHtmlString ProjectsListDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("projectsListDescription"); }
		}

		///<summary>
		/// Projects List Title: The title of the projects' list page.
		///</summary>
		[ImplementPropertyType("projectsListTitle")]
		public string ProjectsListTitle
		{
			get { return this.GetPropertyValue<string>("projectsListTitle"); }
		}
	}

	/// <summary>Projects Item</summary>
	[PublishedContentModel("projectsItem")]
	public partial class ProjectsItem : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectsItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectsItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectsItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Gallery: Insert images for a gallery.
		///</summary>
		[ImplementPropertyType("projectGallery")]
		public IEnumerable<IPublishedContent> ProjectGallery
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("projectGallery"); }
		}

		///<summary>
		/// Project Content: The description of the project.
		///</summary>
		[ImplementPropertyType("projectItemContent")]
		public IHtmlString ProjectItemContent
		{
			get { return this.GetPropertyValue<IHtmlString>("projectItemContent"); }
		}

		///<summary>
		/// Project Main Image: The main image of the project.
		///</summary>
		[ImplementPropertyType("projectItemMainImage")]
		public IPublishedContent ProjectItemMainImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("projectItemMainImage"); }
		}

		///<summary>
		/// Project Title: The title of the project.
		///</summary>
		[ImplementPropertyType("projectItemTitle")]
		public string ProjectItemTitle
		{
			get { return this.GetPropertyValue<string>("projectItemTitle"); }
		}

		///<summary>
		/// Project Managers: The people or companies behind the project.
		///</summary>
		[ImplementPropertyType("projectManagers")]
		public IEnumerable<IPublishedContent> ProjectManagers
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("projectManagers"); }
		}

		///<summary>
		/// Read More Link: Insert a link to another website where users can read more about the project. E.g. http://www.yourwebsite.com
		///</summary>
		[ImplementPropertyType("projectReadMoreLink")]
		public string ProjectReadMoreLink
		{
			get { return this.GetPropertyValue<string>("projectReadMoreLink"); }
		}

		///<summary>
		/// Read More Title: The title of the Read More Link
		///</summary>
		[ImplementPropertyType("projectReadMoreTitle")]
		public string ProjectReadMoreTitle
		{
			get { return this.GetPropertyValue<string>("projectReadMoreTitle"); }
		}

		///<summary>
		/// Status: The status of the project (choose status from the dropdown-menu).
		///</summary>
		[ImplementPropertyType("status")]
		public string Status
		{
			get { return this.GetPropertyValue<string>("status"); }
		}
	}

	/// <summary>About Us</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// GridLayout: The layout for the page
		///</summary>
		[ImplementPropertyType("gridLayout")]
		public Newtonsoft.Json.Linq.JToken GridLayout
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("gridLayout"); }
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("text")]
	public partial class Text : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "text";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Text(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Text, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text Page Main Content: The content of the page.
		///</summary>
		[ImplementPropertyType("textPageMainContent")]
		public IHtmlString TextPageMainContent
		{
			get { return this.GetPropertyValue<IHtmlString>("textPageMainContent"); }
		}

		///<summary>
		/// Text Page Title: The title of the page.
		///</summary>
		[ImplementPropertyType("textPageTitle")]
		public string TextPageTitle
		{
			get { return this.GetPropertyValue<string>("textPageTitle"); }
		}
	}

	/// <summary>Contact Page</summary>
	[PublishedContentModel("contactPage")]
	public partial class ContactPage : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description: The description on the Contact Page.
		///</summary>
		[ImplementPropertyType("contactDescription")]
		public IHtmlString ContactDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("contactDescription"); }
		}
	}

	/// <summary>Comment</summary>
	[PublishedContentModel("comment")]
	public partial class Comment : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "comment";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Comment(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Comment, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Email: The email of the user leaving the comment.
		///</summary>
		[ImplementPropertyType("cEmail")]
		public string CEmail
		{
			get { return this.GetPropertyValue<string>("cEmail"); }
		}

		///<summary>
		/// Message: The message of the comment left.
		///</summary>
		[ImplementPropertyType("cMessage")]
		public string CMessage
		{
			get { return this.GetPropertyValue<string>("cMessage"); }
		}

		///<summary>
		/// Name: The name of the user leaving the comment.
		///</summary>
		[ImplementPropertyType("cName")]
		public string CName
		{
			get { return this.GetPropertyValue<string>("cName"); }
		}

		///<summary>
		/// Subject: The subject of the comment left.
		///</summary>
		[ImplementPropertyType("cSubject")]
		public string CSubject
		{
			get { return this.GetPropertyValue<string>("cSubject"); }
		}
	}

	/// <summary>Message</summary>
	[PublishedContentModel("message")]
	public partial class Message : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "message";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Message(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Message, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Email: The email of the user leaving the message.
		///</summary>
		[ImplementPropertyType("mEmail")]
		public string MEmail
		{
			get { return this.GetPropertyValue<string>("mEmail"); }
		}

		///<summary>
		/// Message: The content of the message left.
		///</summary>
		[ImplementPropertyType("mMessage")]
		public string MMessage
		{
			get { return this.GetPropertyValue<string>("mMessage"); }
		}

		///<summary>
		/// Name: The name of the user leaving the message.
		///</summary>
		[ImplementPropertyType("mName")]
		public string MName
		{
			get { return this.GetPropertyValue<string>("mName"); }
		}

		///<summary>
		/// Title: The title of the message left.
		///</summary>
		[ImplementPropertyType("mTitle")]
		public string MTitle
		{
			get { return this.GetPropertyValue<string>("mTitle"); }
		}
	}

	/// <summary>Message Board</summary>
	[PublishedContentModel("messageBoard")]
	public partial class MessageBoard : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "messageBoard";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MessageBoard(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MessageBoard, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description: Describe the page if needed.
		///</summary>
		[ImplementPropertyType("messageBoardDescription")]
		public IHtmlString MessageBoardDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("messageBoardDescription"); }
		}
	}

	/// <summary>Members</summary>
	[PublishedContentModel("members")]
	public partial class Members : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "members";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Members(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Members, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description: Description of the member page.
		///</summary>
		[ImplementPropertyType("memberPageDescription")]
		public IHtmlString MemberPageDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("memberPageDescription"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Active</summary>
	[PublishedContentModel("active")]
	public partial class Active : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "active";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Active(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Active, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return this.GetPropertyValue<string>("address"); }
		}

		///<summary>
		/// City
		///</summary>
		[ImplementPropertyType("city")]
		public string City
		{
			get { return this.GetPropertyValue<string>("city"); }
		}

		///<summary>
		/// First Name
		///</summary>
		[ImplementPropertyType("firstName")]
		public string FirstName
		{
			get { return this.GetPropertyValue<string>("firstName"); }
		}

		///<summary>
		/// Last Name
		///</summary>
		[ImplementPropertyType("lastName")]
		public string LastName
		{
			get { return this.GetPropertyValue<string>("lastName"); }
		}

		///<summary>
		/// Job Title: The title of the member.
		///</summary>
		[ImplementPropertyType("memberJobTitle")]
		public string MemberJobTitle
		{
			get { return this.GetPropertyValue<string>("memberJobTitle"); }
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Photo
		///</summary>
		[ImplementPropertyType("photo")]
		public Umbraco.Web.Models.ImageCropDataSet Photo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("photo"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}

		///<summary>
		/// Zip
		///</summary>
		[ImplementPropertyType("zip")]
		public string Zip
		{
			get { return this.GetPropertyValue<string>("zip"); }
		}
	}

	/// <summary>Prospect</summary>
	[PublishedContentModel("prospect")]
	public partial class Prospect : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "prospect";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Prospect(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Prospect, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// First Name
		///</summary>
		[ImplementPropertyType("firstName")]
		public string FirstName
		{
			get { return this.GetPropertyValue<string>("firstName"); }
		}

		///<summary>
		/// Last Name
		///</summary>
		[ImplementPropertyType("lastName")]
		public string LastName
		{
			get { return this.GetPropertyValue<string>("lastName"); }
		}

		///<summary>
		/// Job Title: The title of the member
		///</summary>
		[ImplementPropertyType("memberJobTitle")]
		public string MemberJobTitle
		{
			get { return this.GetPropertyValue<string>("memberJobTitle"); }
		}

		///<summary>
		/// Mobile
		///</summary>
		[ImplementPropertyType("mobile")]
		public string Mobile
		{
			get { return this.GetPropertyValue<string>("mobile"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
