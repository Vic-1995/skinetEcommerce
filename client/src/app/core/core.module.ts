import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { TestErrorComponent } from './test-error/test-error.component';
import { SharedModule } from '../shared/shared.module';
import { NavBarComponent } from '../nav-bar/nav-bar.component';
import { NgModule } from '@angular/core';
import { ContactUsComponent } from './contact-us/contact-us.component';



@NgModule({
  declarations: [NavBarComponent, ContactUsComponent, TestErrorComponent],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule
  
  ],
  exports: [NavBarComponent]
})
export class CoreModule { }