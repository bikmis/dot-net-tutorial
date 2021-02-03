- What is ng-content?
    <ng-content></ng-content> projects content from a parent componet into a child component. We can pass dynamic text, html tags, components.
    AddButtonChildComponent
        selector: 'add-btn'
        template: `<button class="" (click)="add()">
                        <ng-content></ng-content>
                   </button>`

    ParentComponent
        <add-btn>Add New Item</add-btn>

- What is ng-template?
    Angular translates a structural directive such as *ngIf attribute into a <ng-template> element wrapped around the host element.
        <div *ngIf="hero" class="name">{{hero.name}}</div>
            translates into 
        <ng-template [ngIf]="hero">
            <div class="name">{{hero.name}}</div>
        </ng-template>

- Angular CLI

- Unit testing with Karma / Jasmine ng-test and end-to-end test with protractor

- Lifecycle hooks - ngOnChanges, ngOnInit, ngDoCheck, ngAfterContentInit, ngAfterContentChecked, ngAfterViewInit, ngAfterViewChecked, ngOnDestroy

- We can render angular application on the server side.

- Dependency injection- We can make an injectable service and provide it in root. Then we can call it from any of the components.

- AOT (ahead of time) compilation: The application compiles during the build time for fast rendering.

- JIT (just in time) compilation: The compiles inside the browser during runtime.

- Interpolation is done using {{}} to bind data one-way from the component to the view.

- Authentication and Authorization

- ng generate component name, ng generate directive name, ng g enum name, ng g guard name, ng g interceptor name, ng g interface name

- Difference between Observable and Promise: Observables are lazy and nothing happens until subscribed, but once a promise is built, it is executed. Promises 
    handle a single event whereas observalble is a stream of data/event

- Directive: (a) attribute (ngClass, ngStyle) (b) structural (*ngIf, *ngFor, *ngSwitch) (c) custom

- Building blocks of Angular: component, data binding, dependency injection, directive, metadata, module, routing, service, template

- Data binding: event binding, property binding, two-way binding

- RxJs (Reactive programming)

- TypeScript

- npm install

- ng new projectName, ng build, ng serve, ng e2e (end to end testing with protractor), ng test (opens in the browser and in the command line shows errors)

- Transfering values from parent to child components: 
    Create voter input varialbe in the child component.
       @Input() voter: Voter = <Voter>{} 
    Write the following code in the child template:
       <p>Voter's Name: {{voter.name}}</p>
    Write the following in the parent template:
       <app-child [voter]="voter"></app-child>
    Write the following in the parent component:
       public voter: Voter = <Voter>{ name: "John" };

- Transfering values from child to parent components: @Output()
    In the child component write the following code:
      @Output() voteEvent = new EventEmitter<boolean>();
      public vote(agreed: boolean){
        this.voteEvent.emit(agreed);
      }
    In the child template write the folloiwng code:
      <button (click)="vote(true)">Agree</button>
      <button (click)="vote(false)">Disagree</button>

    In the parent component, write the following code:
      public agree = 0;
      public disagree = 0;

      public onVoted(agreed: boolean) {
        agreed ? this.agree++ : this.disagree++;
      }

    In the parent template, write the following code:
      <app-child (voteEvent)="onVoted($event)"></app-child>

- Transferring values between components using Subject and subscribing to it in another component.     

- NgModules are eagerly loaded, which means as soon as the app loads, so do all the NgModules, whether
    or not they are immediately necessary. For large apps with lots of routes, consider lazy loading - a design
    pattern that loads NgModules as needed. Lazy loading helps keep initial bundle sizes smaller, which in turn
    helps decrease load times. loadChildren with import used in a route to enable lazy-loading of a module.
