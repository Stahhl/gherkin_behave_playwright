<script lang="ts">
	import { user } from '../lib/store';
	import { goto } from '$app/navigation';

	let pwd1 = '';
	let pwd2 = '';

	function handleOnSubmit() {
		if ($user.name == '') {
			alert('No Name!');
			return;
		}
		if ($user.email == '') {
			alert('No Email!');
			return;
		}
		if (pwd1 == '' || pwd2 == '') {
			alert('No Password!');
			return;
		}
		if (pwd1 != pwd2) {
			alert('Passwords do not match');
			return;
		}

		goto("/home")
	}
</script>

<form class="content" on:submit|preventDefault={handleOnSubmit}>
	<h1>Register</h1>

	<label for="name">Name</label>
	<input type="text" bind:value={$user.name} />
	<label for="email">E-mail</label>
	<input type="text" bind:value={$user.email} />
	<label for="pwd1">Password</label>
	<input type="text" bind:value={pwd1} />
	<label for="pwd2">Password again</label>
	<input type="text" bind:value={pwd2} />

	<input type="submit" value="Submit" />
</form>

<style>
	.content {
		margin: auto;
		width: 50%;
		padding: 10px;
	}

	input[type='text'] {
		width: 100%;
		padding: 12px 20px;
		margin: 8px 0;
		display: inline-block;
		border: 1px solid #ccc;
		border-radius: 4px;
		box-sizing: border-box;
	}

	input[type='submit'] {
		width: 100%;
		background-color: #4caf50;
		color: white;
		padding: 14px 20px;
		margin: 8px 0;
		border: none;
		border-radius: 4px;
		cursor: pointer;
	}

	input[type='submit']:hover {
		background-color: #45a049;
	}
</style>
