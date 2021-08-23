import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { TestErrorComponent } from './test-error/test-error.component';
import { SharedModule } from '../shared/shared.module';
import { NavBarComponent } from '../nav-bar/nav-bar.component';
import { NgModule } from '@angular/core';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ServerErrorComponent } from './server-error/server-error.component';
import { ToastrModule } from 'ngx-toastr';



@NgModule({
  declarations: [NavBarComponent, ContactUsComponent, TestErrorComponent, NotFoundComponent, ServerErrorComponent],
  imports: [
    CommonModule,
    RouterModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
      preventDuplicates: true
    }
     
    )
  
  ],
  exports: [NavBarComponent]
})
export class CoreModule { }