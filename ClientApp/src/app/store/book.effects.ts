import { BookService } from "../services/book.service";
import {Actions, Effect, ofType} from '@ngrx/effects';
import {mergeMap, map} from 'rxjs/operators';
import {Action} from '@ngrx/store';
import * as types from './action.types';
import * as bookActions from './book.actions';

import { Observable } from "rxjs";

export class BookEffects 
{
    constructor(private service: BookService,
        private actions$: Actions){}

    @Effect() loadBooks$: Observable<Action> = this.actions$.pipe(
        ofType<bookActions.loadBooksAction>(types.LOAD_BOOKS),
        mergeMap(() => 
            this.service.getAllBooks().pipe(map(books => 
                new bookActions.loadBooksSuccessAction(books)))
        )
    )

    @Effect() deleteBook$: Observable<Action> = this.actions$.pipe(
        ofType<bookActions.deleteBookAction>(types.DELETE_BOOK),
        mergeMap(action => 
            this.service.deleteBook(action.payload).pipe(map((book:Book) => 
                new bookActions.deleteBookSuccessAction(book.id)))
        )
    )

}