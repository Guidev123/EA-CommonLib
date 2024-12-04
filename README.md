
<p align="center">
  <a href="https://dotnet.microsoft.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg" width="120" alt=".NET Logo" /></a>
</p>

<h1>Utility Library - EDA (Event Driven Architecture) with .NET Core</h1>

<p>This utility library was developed with .NET Core and provides a robust implementation for message queue communication using RabbitMQ. It is designed for projects that use CQRS with MediatR, as well as for projects that rely on message queue communication with RabbitMQ. It supports the Publisher/Subscriber and RPC communication patterns, as well as includes several useful methods to simplify working with queues and messages in distributed systems.</p>

<h2>Features</h2>

<ul>
  <li>
    <strong>Response Utilities</strong>
    <ul>
      <li><strong>Response:</strong> A generic class for standardizing responses.</li>
      <li><strong>PagedResponse:</strong> A utility class for handling paginated responses in APIs and query systems.</li>
    </ul>
  </li>
  <li>
    <strong>Message Base Classes</strong>
    <ul>
      <li>Provides base classes for commands, command handlers, events, and messages.</li>
    </ul>
  </li>
  <li>
    <strong>MessageBus</strong>
    <ul>
      <li>Interface and implementation of a custom RabbitMQ-based message queue communication library.</li>
      <li>Implements Dependency Injection for seamless integration.</li>
    </ul>
  </li>
  <li>
    <strong>MessageBus/Integration</strong>
    <ul>
      <li>Contains base classes for integration events and custom application-specific integration events.</li>
    </ul>
  </li>
  <li>
    <strong>Mediator</strong>
    <ul>
      <li>Interfaces and base classes for <code>MediatorHandler</code> and <code>MediatorEventsExtension</code>, simplifying event dispatch.</li>
    </ul>
  </li>
  <li>
    <strong>Extensions</strong>
    <ul>
      <li><code>PollyExtensions</code>: Helpful extensions for using Polly in resilient communication patterns.</li>
    </ul>
  </li>
  <li>
    <strong>DomainObjects</strong>
    <ul>
      <li>Base entity class, <code>IAggregateRoot</code> marker interface, and <code>DomainException</code> for domain-driven design (DDD) projects.</li>
    </ul>
  </li>
  <li>
    <strong>Controllers</strong>
    <ul>
      <li><code>MainController</code>: A base controller class that all other controllers should inherit from.</li>
    </ul>
  </li>
</ul>

