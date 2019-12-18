using System;

namespace MauticApiClient.Net.Model
{
    public class Email
    {
        public bool IsPublished { get; set; }

        public DateTime? DateAdded { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedByUser { get; set; }

        public DateTime? DateModified { get; set; }

        public string ModifiedBy { get; set; }

        public string ModifiedByUser { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        /*
        "language":"en",
        "category":null,
        "fromAddress":null,
        "fromName":null,
        "replyToAddress":null,
        "bccAddress":null,
        "customHtml":"<h1>Hi there!<\/h1>",
        "plainText":null,
        "template":null,
        "emailType":"list",
        "publishUp":null,
        "publishDown":null,
        "readCount":0,
        "sentCount":0,
        "revision":1,
        "assetAttachments":[],
        "variantStartDate":null,
        "variantSentCount":0,
        "variantReadCount":0,
        "variantParent":null,
        "variantChildren":[],
        "translationParent":null,
        "translationChildren":[],
        "unsubscribeForm":null,
        "dynamicContent":[
          {  
            "tokenName":null,
            "content":null,
            "filters":[
              {  
                "content":null,
                "filters":[
                  {  
                    "glue":null,
                    "field":null,
                    "object":null,
                    "type":null,
                    "operator":null,
                    "display":null,
                    "filter":null
                  }
                ]
              }
            ]
          }
        ],
        "lists":[
          {  
            "createdByUser":"John Doe",
            "modifiedByUser":null,
            "id":256,
            "name":"test",
            "alias":"test29",
            "description":null
          }
        ]
      }
      */
    }
}
