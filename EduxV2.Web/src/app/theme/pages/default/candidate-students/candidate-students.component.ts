import { Component, OnInit, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { Helpers } from '../../../../helpers';
import { ScriptLoaderService } from '../../../../_services/script-loader.service';

@Component({
selector: "candidate-students",
templateUrl: "./candidate-students.component.html",
encapsulation: ViewEncapsulation.None,
})
export class CandidateStudentsComponent implements OnInit, AfterViewInit {

constructor(private _script: ScriptLoaderService)  {

}
ngOnInit()  {

}
    ngAfterViewInit() {
        
this._script.loadScripts('candidate-students',
['assets/demo/default/custom/components/datatables/base/data-ajax.js']);

}
    
}

