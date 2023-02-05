import { writable } from 'svelte/store';

export type User = {
    name: string,
    password: string,
    email: string,
    newsletter: boolean
}

export const user = writable<User>({name: '', password: '', email: '', newsletter: false})