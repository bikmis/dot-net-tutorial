1. What is ng-content, ng-template

2. Angular CLI

3. Unit testing with Karma / Jasmine ng-test and end-to-end test with protractor

4. Lifecycle hooks - ngOnChanges, ngOnInit, ngDoCheck, ngAfterContentInit, ngAfterContentChecked, ngAfterViewInit, ngAfterViewChecked, ngOnDestroy

5. We can render angular application on the server side.

6. Dependency injection- We can make an injectable service and provide it in root. Then we can call it from any of the components.

7. AOT (ahead of time) compilation: The application compiles during the build time for fast rendering.

8. JIT (just in time) compilation: The compiles inside the browser during runtime.

9. Interpolation is done using {{}} to bind data one-way from the component to the view.

10. Authentication and Authorization

11. ng generate component name, ng generate directive name, ng g enum name, ng g guard name, ng g interceptor name, ng g interface name

12. Difference between Observable and Promise: Observables are lazy and nothing happens until subscribed, but once a promise is built, it is executed. Promises 
    handle a single event whereas observalble is a stream of data/event

13. Directive: (a) attribute (ngClass, ngStyle) (b) structural (*ngIf, *ngFor, *ngSwitch) (c) custom

14. Building blocks of Angular: component, data binding, dependency injection, directive, metadata, module, routing, service, template

15. Data binding: event binding, property binding, two-way binding

16. RxJs (Reactive programming)

17. TypeScript

18. npm install

19. ng new projectName, ng build, ng serve, ng e2e (end to end testing with protractor), ng test (opens in the browser and in the command line shows errors)

20. Transfering values from parent to child components: 
    Create voter input varialbe in the child component.
       @Input() voter: Voter = <Voter>{} 
    Write the following code in the child template:
       <p>Voter's Name: {{voter.name}}</p>
    Write the following in the parent template:
       <app-child [voter]="voter"></app-child>
    Write the following in the parent component:
       public voter: Voter = <Voter>{ name: "John" };

21. Transfering values from child to parent components: @Output()
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

22. Transferring values between components using Subject and subscribing to it in another component.     
 