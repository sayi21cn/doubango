/*
* Copyright (C) 2009 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou@yahoo.fr>
*	
* This file is part of Open Source Doubango Framework.
*
* DOUBANGO is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*	
* DOUBANGO is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*	
* You should have received a copy of the GNU General Public License
* along with DOUBANGO.
*
*/

/**@file tsk_mutex.h
 * @brief Pthread mutex.
 *
 * @author Mamadou Diop <diopmamadou(at)yahoo.fr>
 *
 * @date Created: Sat Nov 8 16:54:58 2009 mdiop
 */
#ifndef _TEST_MUTEX_H_
#define _TEST_MUTEX_H_

int mutex_testing = 0;
int mutex_threa_started = 0;

void *threadfunc_mutex(void *parm)
{
	tsk_mutex_handle_t *mutex = (tsk_mutex_handle_t *)parm;
	int ret = 0;
	
	ret =  tsk_mutex_lock(mutex);
	while(mutex_testing)
	{
		mutex_threa_started = 1;
		tsk_mutex_lock(mutex);
	}

	printf("threadfunc_mutex/// %d\n", ret);

	return 0;
}


/* Pthread mutex */
void test_mutex()
{
	tsk_mutex_handle_t *mutex = tsk_mutex_create();
	void*       tid[1] = {0};

	printf("test_mutex//\n");

	mutex_testing = 1;
	tsk_thread_create(&tid[0], threadfunc_mutex, mutex);

	while(!mutex_threa_started);

	mutex_testing = 0;
	tsk_mutex_unlock(mutex);

	tsk_thread_join(&(tid[0]));

	tsk_mutex_destroy(&mutex);
}

#endif /* _TEST_MUTEX_H_ */
