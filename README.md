# Simple NLog
Simple config NLog write file to  Directory where the application runs.
## Getting started
* [Download NLog](https://nlog-project.org/)
* [Github NLog](https://github.com/NLog/NLog)
### NLog.config
```NLog.config
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      xsi:schemaLocation="http://www.nlog-project.org/schemas/NLog.xsd NLog.xsd"
      autoReload="true"
      throwExceptions="false"
      internalLogLevel="Off" internalLogFile="c:\temp\nlog-internal.log">
  <variable name="logDirectory" value="${basedir}/logs/" />
  <targets>

    <target xsi:type="ColoredConsole"
            name="console"  layout="${longdate} ${callsite} ${level} ${message}" />

    <target xsi:type="ColoredConsole"
            name="consoleError"  layout="Error = ${longdate} ${callsite} ${level} ${message}" />

    <target xsi:type="File"
          name="file"
          fileName="${logDirectory}log-information-${shortdate}.json">
      <layout xsi:type="JsonLayout">
        <attribute name="time" layout="${longdate}" />
        <attribute name="level" layout="${uppercase:${level}}" />
        <attribute name="message" layout="${message}" escapeUnicode="false" />
        <attribute name="exception" layout="${exception:format=ToString,StackTrace}${newline}" escapeUnicode="false" />
      </layout>
    </target>

  </targets>

  <rules>
    <logger name="*" minlevel="Trace" writeTo="console" />
    <logger name="*" minlevel="Trace"  levels="Error" writeTo="consoleError" />
    <logger name="*" minlevel="Trace" writeTo="file" />
  </rules>
</nlog>
```
