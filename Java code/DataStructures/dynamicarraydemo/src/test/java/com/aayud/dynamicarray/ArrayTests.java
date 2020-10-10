package com.aayud.dynamicarray;

import junit.framework.TestCase;

public class ArrayTests extends TestCase {
    public void testArray() {
        assertTrue(true);
    }
    public void Array_WhenInitial_ShouldReturnLengthOfZero() {
        Array<Integer> myArray = new Array<Integer>(2);
        assertEquals(0,myArray.size());
    }
}
