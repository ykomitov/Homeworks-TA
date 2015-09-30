## XML Basics Homework

### 1. What does the XML language represent? What is it used for? 

XML stands for EXtensible Markup Language. It is a software- and hardware-independent language for storing and transporting data. XML is human-readable and was designed to be self-descriptive.

### 2. XML document students.xml, which contains structured description of students

[students.xml](students.xml)

### 3. What do namespaces represent in an XML document? What are they used for? 

In XML, element names are defined by the developer. This often results in a conflict when trying to mix XML documents from different XML applications. XML Namespaces provide a method to avoid element name conflicts.

### 4. URI, URN and URL definitions

- Uniform Resource Identifier (URI) is a string of characters used to identify the name of a resource

- A URL is a URI that, in addition to identifying a web resource, specifies the means of acting upon or obtaining the representation of it, i.e. specifying both its primary access mechanism and network location. 

- A URN is a URI that identifies a resource by name in a particular namespace. A URN can be used to talk about a resource without implying its location or how to access it.

### 5. Add default namespace for students "urn:students".


### 6. Create XSD Schema for students.xml document. 
[students.xsd](students.xsd)

### 7. Write an XSL stylesheet to visualize the students as HTML. 
[students-xml2html](students-xml2html.xsl)