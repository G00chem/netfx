using System.Diagnostics;

namespace System.Xml
{
	/// <summary>
	/// Base <see cref="XmlWriter"/> that can be use to create new writers by 
	/// wrapping existing ones.
	/// </summary>
#if NetFx
	public abstract class XmlWrappingWriter : XmlWriter
#else
	internal abstract class XmlWrappingWriter : XmlWriter
#endif
	{
		// Fields
		protected XmlWriter writer;

		// Methods
		protected XmlWrappingWriter(XmlWriter baseWriter)
		{
			this.Writer = baseWriter;
		}

		public override void Close()
		{
			this.writer.Close();
		}

		[DebuggerStepThrough]
		protected override void Dispose(bool disposing)
		{
			((IDisposable)this.writer).Dispose();
		}

		[DebuggerStepThrough]
		public override void Flush()
		{
			this.writer.Flush();
		}

		public override string LookupPrefix(string ns)
		{
			return this.writer.LookupPrefix(ns);
		}

		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.writer.WriteBase64(buffer, index, count);
		}

		public override void WriteCData(string text)
		{
			this.writer.WriteCData(text);
		}

		public override void WriteCharEntity(char ch)
		{
			this.writer.WriteCharEntity(ch);
		}

		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.writer.WriteChars(buffer, index, count);
		}

		public override void WriteComment(string text)
		{
			this.writer.WriteComment(text);
		}

		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.writer.WriteDocType(name, pubid, sysid, subset);
		}

		public override void WriteEndAttribute()
		{
			this.writer.WriteEndAttribute();
		}

		public override void WriteEndDocument()
		{
			this.writer.WriteEndDocument();
		}

		public override void WriteEndElement()
		{
			this.writer.WriteEndElement();
		}

		public override void WriteEntityRef(string name)
		{
			this.writer.WriteEntityRef(name);
		}

		public override void WriteFullEndElement()
		{
			this.writer.WriteFullEndElement();
		}

		public override void WriteProcessingInstruction(string name, string text)
		{
			this.writer.WriteProcessingInstruction(name, text);
		}

		public override void WriteRaw(string data)
		{
			this.writer.WriteRaw(data);
		}

		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.writer.WriteRaw(buffer, index, count);
		}

		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.writer.WriteStartAttribute(prefix, localName, ns);
		}

		public override void WriteStartDocument()
		{
			this.writer.WriteStartDocument();
		}

		public override void WriteStartDocument(bool standalone)
		{
			this.writer.WriteStartDocument(standalone);
		}

		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.writer.WriteStartElement(prefix, localName, ns);
		}

		public override void WriteString(string text)
		{
			this.writer.WriteString(text);
		}

		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.writer.WriteSurrogateCharEntity(lowChar, highChar);
		}

		public override void WriteValue(bool value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(DateTime value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(decimal value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(double value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(int value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(long value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(object value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(float value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteValue(string value)
		{
			this.writer.WriteValue(value);
		}

		public override void WriteWhitespace(string ws)
		{
			this.writer.WriteWhitespace(ws);
		}

		// Properties
		public override XmlWriterSettings Settings
		{
			get { return this.writer.Settings; }
		}

		protected XmlWriter Writer
		{
			get { return this.writer; }
			set { this.writer = value; }
		}

		public override WriteState WriteState
		{
			get { return this.writer.WriteState; }
		}

		public override string XmlLang
		{
			get { return this.writer.XmlLang; }
		}

		public override XmlSpace XmlSpace
		{
			get { return this.writer.XmlSpace; }
		}
	}
}
