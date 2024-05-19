import {Action} from '@ngrx/store';
import * as types from './action.types';

export class loadBooksAction implements Action
{
    readonly type = types.LOAD_BOOKS;
    constructor(){}
}

export class loadBooksSuccessAction implements Action
{
    readonly type = types.LOAD_BOOKS_SUCCESS;
    constructor(public payload: Book[]){}
}

export class deleteBookAction implements Action
{
    readonly type = types.DELETE_BOOK;
    constructor(public payload: number){}
}

export class deleteBookSuccessAction implements Action
{
    readonly type = types.DELETE_BOOK_SUCCESS;
    constructor(public payload: number){}
}

export type Actions = loadBooksAction | loadBooksSuccessAction | deleteBookAction | deleteBookSuccessAction