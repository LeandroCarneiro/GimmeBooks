import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BooksComponent } from './books.component';
import { BooksRoutingModule } from './books-routing.module';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { SafePipe } from './safe.pipe';

@NgModule({
  imports: [
    CommonModule,
    BooksRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  exports: [
    BooksComponent
  ],
  declarations: [
    BooksComponent,
    SafePipe    
  ],
  providers: [
  ],
})
export class BooksModule { }