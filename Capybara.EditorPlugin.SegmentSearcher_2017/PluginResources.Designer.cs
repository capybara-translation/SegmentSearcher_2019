﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capybara.EditorPlugin.SegmentSearcher_2017 {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PluginResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PluginResources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Capybara.EditorPlugin.SegmentSearcher_2017.PluginResources", typeof(PluginResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   @charset &quot;UTF-8&quot;;
        ///
        ///body {
        ///	font-family:&apos;Arial Unicode MS&apos;;
        ///	font-size: 70%;
        ///}
        ///
        ///#results {
        ///	border-collapse: collapse;
        ///}
        ///
        ///#results th, td {
        ///    border: 1px #000000 dashed;
        ///	padding: 5px;
        ///}
        ///
        ///#results thead {
        ///	background: #6485B4;
        ///	border: 1px #000000 solid;
        ///}
        ///
        ///.entry-odd {
        ///	background: #E6EAEE;
        ///}
        ///
        ///#results tbody {
        ///	border: 1px #000000 solid;
        ///}
        ///
        ///#results tbody:hover {
        ///	background: #9EC9D7;
        ///}
        ///
        ///td.file-id {
        ///    display: none;
        ///}
        ///
        ///.seg-info {
        ///	text-align: center;
        ///}
        ///
        ///.seg-in [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string base_css {
            get {
                return ResourceManager.GetString("base_css", resourceCulture);
            }
        }
        
        /// <summary>
        ///   &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.0 Transitional//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot;&gt;
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot; xml:lang=&quot;en&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html;charset=UTF-8&quot;/&gt;
        ///    &lt;meta http-equiv=&quot;X-UA-Compatible&quot; content=&quot;IE=edge, chrome=1&quot; /&gt;
        ///	&lt;link rel=&quot;stylesheet&quot; href=&quot;base.css&quot; type=&quot;text/css&quot; charset=&quot;UTF-8&quot; /&gt;
        ///    &lt;script type=&quot;text/javascript&quot; src=&quot;jquery.js&quot;&gt;&lt;/script&gt;
        /// [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string base_html {
            get {
                return ResourceManager.GetString("base_html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   /*! jQuery v1.9.1 | (c) 2005, 2012 jQuery Foundation, Inc. | jquery.org/license
        /////@ sourceMappingURL=jquery.min.map
        ///*/(function(e,t){var n,r,i=typeof t,o=e.document,a=e.location,s=e.jQuery,u=e.$,l={},c=[],p=&quot;1.9.1&quot;,f=c.concat,d=c.push,h=c.slice,g=c.indexOf,m=l.toString,y=l.hasOwnProperty,v=p.trim,b=function(e,t){return new b.fn.init(e,t,r)},x=/[+-]?(?:\d*\.|)\d+(?:[eE][+-]?\d+|)/.source,w=/\S+/g,T=/^[\s\uFEFF\xA0]+|[\s\uFEFF\xA0]+$/g,N=/^(?:(&lt;[\w\W]+&gt;)[^&gt;]*|#([\w-]*))$/,C=/^&lt;(\w+)\s*\/?&gt;(?:&lt;\/\1&gt;|)$/,k=/^ [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string jquery {
            get {
                return ResourceManager.GetString("jquery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   $(function () {
        ///    $(&apos;select[name=&quot;file-filter&quot;]&apos;).change(function (event) {
        ///        var allCount = $(&apos;#all-count&apos;).text();
        ///        $(&apos;#filtered-count&apos;).text(allCount);
        ///        var fileId = $(this).val();
        ///        $(&apos;#results tbody&apos;).show();
        ///        if (fileId !== &apos;#ALL#&apos;) {
        ///            var hiddenTbodies = $(&apos;td.file-id:not(:contains(&quot;&apos; + fileId + &apos;&quot;))&apos;).closest(&apos;tbody&apos;);
        ///            $(&apos;#filtered-count&apos;).text(allCount - hiddenTbodies.size());
        ///            hiddenTbodies.hide();
        ///        }
        ///    });
        ///} [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string main_js {
            get {
                return ResourceManager.GetString("main_js", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SegmentSearcher に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Plugin_Description {
            get {
                return ResourceManager.GetString("Plugin_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   SegmentSearcher に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Plugin_Name {
            get {
                return ResourceManager.GetString("Plugin_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon SegmentSearcher_Icon {
            get {
                object obj = ResourceManager.GetObject("SegmentSearcher_Icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Search in opened documents に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SegmentSearcherAction_Description {
            get {
                return ResourceManager.GetString("SegmentSearcherAction_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search by SegmentSearcher に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SegmentSearcherAction_Name {
            get {
                return ResourceManager.GetString("SegmentSearcherAction_Name", resourceCulture);
            }
        }
    }
}